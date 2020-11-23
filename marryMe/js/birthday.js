// 農曆年年基礎數據表
let lunarInfo=new Array(
    0x04bd8,0x04ae0,0x0a570,0x054d5,0x0d260,
    0x0d950,0x16554,0x056a0,0x09ad0,0x055d2,
    0x04ae0,0x0a5b6,0x0a4d0,0x0d250,0x1d255,
    0x0b540,0x0d6a0,0x0ada2,0x095b0,0x14977,
    0x04970,0x0a4b0,0x0b4b5,0x06a50,0x06d40,
    0x1ab54,0x02b60,0x09570,0x052f2,0x04970,
    0x06566,0x0d4a0,0x0ea50,0x06e95,0x05ad0,
    0x02b60,0x186e3,0x092e0,0x1c8d7,0x0c950,
    0x0d4a0,0x1d8a6,0x0b550,0x056a0,0x1a5b4,
    0x025d0,0x092d0,0x0d2b2,0x0a950,0x0b557,
    0x06ca0,0x0b550,0x15355,0x04da0,0x0a5d0,
    0x14573,0x052d0,0x0a9a8,0x0e950,0x06aa0,
    0x0aea6,0x0ab50,0x04b60,0x0aae4,0x0a570,
    0x05260,0x0f263,0x0d950,0x05b57,0x056a0,
    0x096d0,0x04dd5,0x04ad0,0x0a4d0,0x0d4d4,
    0x0d250,0x0d558,0x0b540,0x0b5a0,0x195a6,
    0x095b0,0x049b0,0x0a974,0x0a4b0,0x0b27a,
    0x06a50,0x06d40,0x0af46,0x0ab60,0x09570,
    0x04af5,0x04970,0x064b0,0x074a3,0x0ea50,
    0x06b58,0x055c0,0x0ab60,0x096d5,0x092e0,
    0x0c960,0x0d954,0x0d4a0,0x0da50,0x07552,
    0x056a0,0x0abb7,0x025d0,0x092d0,0x0cab5,
    0x0a950,0x0b4a0,0x0baa4,0x0ad50,0x055d9,
    0x04ba0,0x0a5b0,0x15176,0x052b0,0x0a930,
    0x07954,0x06aa0,0x0ad50,0x05b52,0x04b60,
    0x0a6e6,0x0a4e0,0x0d260,0x0ea65,0x0d530,
    0x05aa0,0x076a3,0x096d0,0x04bd7,0x04ad0,
    0x0a4d0,0x1d0b6,0x0d250,0x0d520,0x0dd45,
    0x0b5a0,0x056d0,0x055b2,0x049b0,0x0a577,
    0x0a4b0,0x0aa50,0x1b255,0x06d20,0x0ada0);

// 定義函式
function DateSelector( selCalendar , selYear , selMonth , selDay ) {
    this.selCalendar = selCalendar;
    this.selYear = selYear;
    this.selMonth = selMonth;
    this.selDay = selDay;
    this.selCalendar.Group = this;
    this.selYear.Group = this;
    this.selMonth.Group = this;

    // 給曆法、年份、月份下拉選單新增處理onchange事件的函式
    this.selCalendar.addEventListener("change", DateSelector.mOnchange, false);
    this.selYear.addEventListener("change", DateSelector.mOnchange, false);

    // 給曆法、年份、月份下拉選單新增處理onchange事件的函式
    this.selCalendar.addEventListener("change", DateSelector.Onchange, false);
    this.selYear.addEventListener("change", DateSelector.Onchange, false);
    this.selMonth.addEventListener("change", DateSelector.Onchange, false);

    this.InitYearSelect(); // 呼叫初始年份
    this.InitMonthSelect(); //呼叫初始月份
}

// ----- 年份相關 -----
// 增加一個最小年份的屬性--最老年份
DateSelector.prototype.MinYear = 1960;
// 增加一個最大年份的屬性--最新年份，即當前時期getFullYear()
DateSelector.prototype.MaxYear = (new Date()).getFullYear();
// 初始化年份
DateSelector.prototype.InitYearSelect = function () {
    // 迴圈新增OPION元素到年份select物件中
    for (let i = this.MaxYear; i >= this.MinYear; i--) {
    // 新建一個OPTION物件
        let op = window.document.createElement("OPTION");
    // 設定OPTION物件的值
        op.value = i;
    // 設定OPTION物件的內容
        op.innerHTML = i;
    // 預設選項
        if (i == 1980) op.selected = true;
    // 新增到年份select物件
        this.selYear.appendChild(op);
    }
};

// ----- 月份相關 -----
// 初始化月份
DateSelector.prototype.InitMonthSelect = function () {
    let baseMonth = [0,1,2,3,4,5,6,7,8,9,10,11,12];
    let newBaseMonty = [];
    // 使用parseInt函式獲取當前的年份和月份
    let calendar = this.selCalendar.value;
    let year = parseInt(this.selYear.value);
    // 獲取當月的天數
    let daysInMonth = DateSelector.MonthInYear(calendar, year);
    if ( daysInMonth != 0 && daysInMonth != undefined) {
        baseMonth.push(daysInMonth);
        baseMonth.sort(function (a, b) {
            return a - b ;
        });
    }
    // 清空原有的選項
    this.selMonth.options.length = 0;
    // 迴圈新增OPION元素到月份select物件中
    for (let i = 0; i < baseMonth.length ; i++) {
        // 新建一個OPTION物件
        let op = window.document.createElement("OPTION");
        // 設定OPTION物件的值
        // 設定OPTION物件的內容
        if ( baseMonth[i] == 0 ) {
            newBaseMonty.push(baseMonth[i]);
            op.value= "";
            op.innerHTML="";
        }
        else if ( newBaseMonty.indexOf(baseMonth[i]) == -1 ) {
            newBaseMonty.push(baseMonth[i]);
            op.value = `${baseMonth[i]} 0`;
            op.innerHTML = baseMonth[i];
        }
        else {
            newBaseMonty.push(`y${baseMonth[i]}`);
            op.value = `${baseMonth[i]} 1`;
            op.innerHTML = `閏${baseMonth[i]}`;
        }
        // 新增到月份select物件
        this.selMonth.appendChild(op);
    }
};
// 根據曆法、年份獲取當月的閏月
DateSelector.MonthInYear = function (calendar, year) {
    if ( calendar == 'lunar' ) {
        return( leapMonth(year) ) ;
    } else { // 沒有曆法則預設國曆
        return ;
    }
};
//== 傳回農曆 y年閏哪個月 1-12 , 沒閏傳回 0
function leapMonth(y) {
    return(lunarInfo[y-1900] & 0xf)
}
// 處理曆法和年份onchange事件的方法
DateSelector.mOnchange = function (e) {
    let selector = e.target;
    selector.Group.InitMonthSelect();
};

// ----- 日期相關 -----
// 根據曆法、年份、月份獲取當月的天數
DateSelector.DaysInMonth = function (calendar, year, month , lunarMonth) {
    if ( calendar == 'lunar' ) {
        return month == lunarMonth ? lunarmonthDays(year,month) : lunarleapDays(year);
    } else { // 沒有曆法則預設國曆
        let date = new Date(year, month, 0);
        return date.getDate();
    }
};
//== 傳回農曆 y年閏月的天數
function lunarleapDays(year) {
    return((lunarInfo[year-1900] & 0x10000)? 30: 29);
}
//== 傳回農曆 y年m月的總天數
function lunarmonthDays(year,month) {
    return( (lunarInfo[year-1900] & (0x10000>>month))? 30: 29 );
}

// 初始化天數
DateSelector.prototype.InitDaySelect = function () {
    // 使用parseInt函式獲取當前的年份和月份
    let calendar = this.selCalendar.value;
    let year = parseInt(this.selYear.value);
    let month = parseInt(this.selMonth.value);
    // 確認選擇的是否為閏月
    let lunarMonthStr = (this.selMonth.value).split(" ");
    let lunarMonth = parseInt(lunarMonthStr[0]) + parseInt(lunarMonthStr[1]);
    // console.log( calendar , year , month );
    // 獲取當月的天數
    let daysInMonth = DateSelector.DaysInMonth(calendar, year, month , lunarMonth );
    // console.log( daysInMonth );
    // 清空原有的選項
    this.selDay.options.length = 0;
    // 迴圈新增OPION元素到天數select物件中
    for (var i = 0; i <= daysInMonth; i++) {
    // 新建一個OPTION物件
        var op = window.document.createElement("OPTION");
    // 設定OPTION物件的值
        i == 0 ?  op.value="" : op.value = i;
    // 設定OPTION物件的內容
        i == 0 ?  op.innerHTML="" : op.innerHTML = i;
    // 新增到天數select物件
        this.selDay.appendChild(op);
    }
};
// 處理年份和月份onchange事件的方法，它獲取事件來源物件（即selYear或selMonth）
// 並呼叫它的Group物件（即DateSelector例項，請見建構函式）提供的InitDaySelect方法重新初始化天數
// 引數e為event物件
DateSelector.Onchange = function (e) {
    let selector = e.target;
    selector.Group.InitDaySelect(); //呼叫初始日期
};
