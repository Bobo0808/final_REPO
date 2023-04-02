<template>
    <div class="container content px-5">
        <div class="row gx-5">
            <div class="col content-body">
                <div class="title">
                    使用者統計
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
                        <li>及時</li>
                        <li>日</li>
                        <li>月</li>
                        <li>年</li>
                    </ul>
                    <canvas class="border bg-light" width="800px" height="400px">
                    </canvas>
                </div>
            </div>
            <div class="col side gx-5 bg-light">
                <div class="title">
                    排行榜
                </div>
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
        border-bottom: 1px solid rgb(55, 156, 223);
        line-height: 3rem;
    }
</style>