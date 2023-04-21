const allSideMenu = document.querySelectorAll('#sidebar .side-menu.top li a');

allSideMenu.forEach(item => {
    const li = item.parentElement;

    item.addEventListener('click', function () {
        allSideMenu.forEach(i => {
            i.parentElement.classList.remove('active');
        })
        li.classList.add('active');
    })
});

const sidebar = document.getElementById('sidebar');

const searchButton = document.querySelector('#content nav form .form-input button');
const searchButtonIcon = document.querySelector('#content nav form .form-input button .bx');
const searchForm = document.querySelector('#content nav form');

searchButton.addEventListener('click', function (e) {
    if (window.innerWidth < 576) {
        e.preventDefault();
        searchForm.classList.toggle('show');
        if (searchForm.classList.contains('show')) {
            searchButtonIcon.classList.replace('bx-search', 'bx-x');
        } else {
            searchButtonIcon.classList.replace('bx-x', 'bx-search');
        }
    }
})

if (window.innerWidth < 768) {
    sidebar.classList.add('hide');
} else if (window.innerWidth > 576) {
    searchButtonIcon.classList.replace('bx-x', 'bx-search');
    searchForm.classList.remove('show');
}

window.addEventListener('resize', function () {
    if (this.innerWidth > 576) {
        searchButtonIcon.classList.replace('bx-x', 'bx-search');
        searchForm.classList.remove('show');
    }
})

const switchMode = document.getElementById('switch-mode');

switchMode.addEventListener('change', function () {
    if (this.checked) {
        document.body.classList.add('dark');
        document.getElementById('sidebar').classList.add('dark');
        const activeBtn = document.querySelectorAll('#sidebar .side-menu li');
        activeBtn.forEach(dBtn => { dBtn.classList.add('dark'); });
        document.getElementById('Search').classList.add('dark');
    } else {
        document.body.classList.remove('dark');
        document.getElementById('sidebar').classList.remove('dark');
        const activeBtn = document.querySelectorAll('#sidebar .side-menu li');
        activeBtn.forEach(dBtn => { dBtn.classList.remove('dark'); });
        document.getElementById('Search').classList.remove('dark');
    }
});
window.addEventListener('load', function () {
    document.getElementById('switch-mode').checked = true;
    document.getElementById('switch-mode').dispatchEvent(new Event('change'));
});