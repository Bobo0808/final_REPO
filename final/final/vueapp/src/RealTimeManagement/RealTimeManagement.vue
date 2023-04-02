<template>
    <div class="container content px-5">
        <div class="row">
            <div class="col content-body gx-5">
                <div class="title">
                    同時在線人數
                </div>
                <div class="head">
                    <ul class="timeSelect">
                        <li>從<input type="date" id="timeStart"></li>
                        <li>到<input type="date" id="timeEnd"></li>
                        <button>查詢</button>
                    </ul>
                </div>
                <div class="head">
                    <ul class="timeSpan">
                        <li>日</li>
                        <li>週</li>
                        <li>月</li>
                        <li>年</li>
                    </ul>
    <li class="topic">數據統計：</li>
    <canvas class="border bg-light" width="800px" height="400px">
    </canvas>
    <ul class="note">
        <li>資料日期：</li>
        <li>累計人數：</li>
    </ul>
    </div>
    </div>
    <div class="col side gx-5 bg-light">
        <div class="title">
            最新看板人數統計
        </div>
        <table>
            <thead class="tdata">
                <tr>
                    <th>2</th>
                    <th>2</th>
                </tr>
            </thead>
            <tbody class="tdata">
                <tr>
                    <td>1</td>
                    <td>1</td>
                </tr>
            </tbody>
        </table>
    </div>
    </div>
    </div>
</template>

<script>
   
</script>

<style>
    .content {
        margin-top: 2rem;
    }

        .content > .row {
            display: flex;
        }

    .content-body {
        flex: 1 1 70%;
    }

    .side {
        flex: 1 1 30%;
    }


    .head {
        display: flex;
        flex-direction: column;
    }

    .timeSelect {
        padding-left: 0;
        display: flex;
        justify-content: space-evenly;
    }

        .timeSelect > li {
            margin-top: 1.5rem;
            list-style-type: none;
        }

            .timeSelect > li > input {
                margin-left: 1rem;
            }

        .timeSelect > button {
            display: inline-block;
            height: fit-content;
            margin-top: auto;
            width: 4rem;
            border-radius: 0.5rem;
        }

    .timeSpan {
        padding-left: 0;
        display: flex;
        flex-direction: row-reverse;
        justify-content: space-evenly;
    }

        .timeSpan > li {
            text-align: center;
            width: 100%;
            list-style-type: none;
            border: 1px solid rgb(55, 156, 223);
            display: block;
            cursor: pointer;
        }

    .title {
        font-size: 1.5rem;
        border-bottom: 1px solid rgb(55, 156, 223);
        line-height: 3rem;
        font-weight: bold;
    }

    .topic {
        list-style-type: none;
        text-align: center;
        margin-bottom: 1rem;
        font-size: 1.2rem;
    }

    .note {
        padding-left: 0;
        display: flex;
        justify-content: space-between;
    }

        .note > li {
            list-style-type: none;
            text-align: center;
            font-style: italic;
        }

    table {
        margin-top: 1rem;
        table-layout: fixed;
        width: 100%;
    }


    .tdata > tr > th,
    td {
        border: 1px solid #aaa;
        padding: 0.5rem;
    }
</style>