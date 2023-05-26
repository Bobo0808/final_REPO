using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using ClassLibrary;

namespace final_repo_test.Areas.CardOrderProduct.Controllers
{
    //[Area("CardOrderProduct")]
    [Area(areaName: "CardOrderProduct")]
    public class CardOrdersController : Controller
    {
        private readonly ChickenDbContext _context;

        public CardOrdersController(ChickenDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //GET: CardOrderProduct/CardOrders
        public async Task<IActionResult> Index(int id = 1)
        {
            var applicationDbContext = _context.CardOrders.Include(c => c.Account).Include(c => c.Card).Include(c => c.CardType);
            // PageSize變數: 每頁幾筆
            int PageSize = 9;

            // RecordCount變數，符合條件的總共有幾筆記錄？
            int RecordCount = _context.CardOrders.Count();

            // NowPageCount 目前正在觀賞這一頁紀錄，目前正在?
            int NowPageCount = 0;
            if (id > 0)
            {
                NowPageCount = (int)((id - 1) * PageSize);
            }
            // orderby順排序 descending反排序
            // skip從哪裡開始(忽略前面幾筆紀錄)
            var ListAll = (from Card in _context.CardOrders
                           orderby Card.CO_ID
                           select Card)
                           .Include(c => c.Account)
                           .Include(c => c.Card)
                           .Include(c => c.CardType)
                         .Skip(NowPageCount)
                         .Take(PageSize);
            //*** 查詢結果 ListAll 是一個 IQueryable ***
            ////if (ListAll == null) // 查無資料時，無法正確運作。因為 IQueryable<T>會傳回一個「空集合」而不是「空（null）。所以這段if辨別不了」
            if (ListAll.Any() == false)  // 可運作
            ////if (ListAll.GetEnumerator().MoveNext() == false)   // 可運作
            {   // 找不到任何記錄。 .NET Core改用 NotFound();
                return NotFound();
            }
            else
            {
                #region
                // Pages變數，「總共需要幾頁」才能把所有紀錄展示完畢？
                int Pages;
                if ((RecordCount % PageSize) > 0)
                {   //-- %，除法，傳回餘數
                    Pages = ((RecordCount / PageSize) + 1);   //-- ( / )除法。傳回整數。  如果無法整除，有餘數，則需要多出一頁來呈現。 
                }
                else
                {
                    Pages = (RecordCount / PageSize);   //-- ( /)除法。傳回整數
                }



                System.Text.StringBuilder sbPageList = new System.Text.StringBuilder();
                if (Pages > 0)
                {   //有傳來「頁數(p)」，而且頁數正確（大於零），出現<上一頁>、<下一頁>這些功能
                    sbPageList.Append("<div align='center'>");

                    //** 可以把檔名刪除，只留下 ?P=  即可！一樣會運作，但IE 11會出現 JavaScript錯誤。**
                    //** 抓到目前網頁的「檔名」。 System.IO.Path.GetFileName(Request.PhysicalPath) **
                    if (id > 1)
                    {   //======== 分頁功能（上一頁 / 下一頁）=========start===                
                        sbPageList.Append("<a href='?id=" + (id - 1) + "'>[<<<上一頁]</a>");
                    }
                    sbPageList.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b><a href='https://backsite.azurewebsites.net/CardOrderProduct/CardOrders'>[首頁]</a></b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
                    if (id < Pages)
                    {
                        sbPageList.Append("<a href='?id=" + (id + 1) + "'>[下一頁>>>]</a>");
                    }  //======== 分頁功能（上一頁 / 下一頁）=========end====


                    //==========================================================
                    //========= MIS2000 Lab.自製的「每十頁」一間隔，分頁功能=========start====
                    sbPageList.Append("<hr width='97%' size=1>");

                    int block_page = 0;
                    block_page = id / 10;   //--只取除法的整數成果（商），若有餘數也不去管它。

                    if (block_page > 0)
                    {
                        sbPageList.Append("<a href='?id=" + (((block_page - 1) * 10) + 9) + "'> [前十頁<<]  </a>&nbsp;&nbsp;");
                    }

                    for (int K = 0; K <= 10; K++)
                    {
                        if ((block_page * 10 + K) <= Pages)
                        {   //--- Pages 資料的總頁數。共需「幾頁」來呈現所有資料？
                            if (((block_page * 10) + K) == id)
                            {   //--- id 就是「目前在第幾頁」
                                sbPageList.Append("[<b>" + id + "</b>]" + "&nbsp;&nbsp;&nbsp;");
                            }
                            else
                            {
                                if (((block_page * 10) + K) != 0)
                                {
                                    sbPageList.Append("<a href='?id=" + (block_page * 10 + K) + "'>" + (block_page * 10 + K) + "</a>");
                                    sbPageList.Append("&nbsp;&nbsp;&nbsp;");
                                }
                            }
                        }
                    }  //for迴圈 end

                    if ((block_page < (Pages / 10)) & (Pages >= (((block_page + 1) * 10) + 1)))
                    {
                        sbPageList.Append("&nbsp;&nbsp;<a href='?id=" + ((block_page + 1) * 10 + 1) + "'>  [>>後十頁]  </a>");
                    }
                    sbPageList.Append("</div>");
                }
                #endregion

                ViewBag.CardOrderPageList = sbPageList.ToString();
                return View(ListAll.ToList());
            }
        }

        //GET: CardOrderProduct/CardOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CardOrders == null)
            {
                return NotFound();
            }

            var cardOrder = await _context.CardOrders
                .Include(c => c.Account)
                .Include(c => c.Card)
                .Include(c => c.CardType)
                .FirstOrDefaultAsync(m => m.CO_ID == id);
            if (cardOrder == null)
            {
                return NotFound();
            }

            return View(cardOrder);
            //return PartialView("_ShowCardOrderPartial", cardOrder); ;
        }

        // GET: CardOrderProduct/CardOrders/Create
        public IActionResult Create()
        {
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name");
            ViewData["CA_ID"] = new SelectList(_context.Cards, "CA_ID", "CA_Name");
            ViewData["CT_ID"] = new SelectList(_context.CardTypes, "CT_ID", "CT_Name");
            return View();
        }

        // POST: CardOrderProduct/CardOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CO_ID,A_ID,CA_ID,CT_ID,CO_Cancel,CO_Date,CO_Sum,CO_Quantity")] CardOrder cardOrder)
        {
            //if (ModelState.IsValid)
            // {
            _context.Add(cardOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //}
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name", cardOrder.A_ID);
            ViewData["CA_ID"] = new SelectList(_context.Cards, "CA_ID", "CA_Name", cardOrder.CA_ID);
            ViewData["CT_ID"] = new SelectList(_context.CardTypes, "CT_ID", "CT_Name", cardOrder.CT_ID);
            //return View(cardOrder);
        }

        // GET: CardOrderProduct/CardOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CardOrders == null)
            {
                return NotFound();
            }

            var cardOrder = await _context.CardOrders.FindAsync(id);
            if (cardOrder == null)
            {
                return NotFound();
            }
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name", cardOrder.A_ID);
            ViewData["CA_ID"] = new SelectList(_context.Cards, "CA_ID", "CA_Name", cardOrder.CA_ID);
            ViewData["CT_ID"] = new SelectList(_context.CardTypes, "CT_ID", "CT_Name", cardOrder.CT_ID);
            return View(cardOrder);
        }

        // POST: CardOrderProduct/CardOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CO_ID,A_ID,CA_ID,CT_ID,CO_Cancel,CO_Date,CO_Sum,CO_Quantity")] CardOrder cardOrder)
        {
            if (id != cardOrder.CO_ID)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(cardOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardOrderExists(cardOrder.CO_ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            ViewData["A_ID"] = new SelectList(_context.Accounts, "A_ID", "A_Name", cardOrder.A_ID);
            ViewData["CA_ID"] = new SelectList(_context.Cards, "CA_ID", "CA_Name", cardOrder.CA_ID);
            ViewData["CT_ID"] = new SelectList(_context.CardTypes, "CT_ID", "CT_Name", cardOrder.CT_ID);
            //return View(cardOrder);
        }

        // GET: CardOrderProduct/CardOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CardOrders == null)
            {
                return NotFound();
            }

            var cardOrder = await _context.CardOrders
                .Include(c => c.Account)
                .Include(c => c.Card)
                .Include(c => c.CardType)
                .FirstOrDefaultAsync(m => m.CO_ID == id);
            if (cardOrder == null)
            {
                return NotFound();
            }

            return View(cardOrder);
        }

        // POST: CardOrderProduct/CardOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CardOrders == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CardOrders'  is null.");
            }
            var cardOrder = await _context.CardOrders.FindAsync(id);
            if (cardOrder != null)
            {
                _context.CardOrders.Remove(cardOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardOrderExists(int id)
        {
            return (_context.CardOrders?.Any(e => e.CO_ID == id)).GetValueOrDefault();
        }
    }
}
