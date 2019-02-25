// ref: https://github.com/yubinbango/yubinbango
// https://github.com/yubinbango/yubinbango-data
// 原本jetfijp直接呼叫'https://yubinbango.github.io/yubinbango-data/data/' + event.jpzip1 + '.js'
// 但這個是jsonp...做一下replace好了
form.on('autoYubinbango', function (event) {
  console.log('emit autoYubinbango ' + event.jpzip1);
  if (!event.jpzip1 || !event.jpzip2) {
    return;
  }
  $.ajax({
    url: 'https://yubinbango.github.io/yubinbango-data/data/' + event.jpzip1 + '.js',
    // dataType: 'json',
    success: function (data) {

      if (data) {
        var yubinMap = {};
        // 刪除 "$yubin(" 以及最後的 ");"
        // array資訊：
        // 0: 區域id
        var prefectureMap = [
          "北海道",
          "青森県",
          "岩手県",
          "宮城県",
          "秋田県",
          "山形県",
          "福島県",
          "茨城県",
          "栃木県",
          "群馬県",
          "埼玉県",
          "千葉県",
          "東京都",
          "神奈川",
          "新潟県",
          "富山県",
          "石川県",
          "福井県",
          "山梨県",
          "長野県",
          "岐阜県",
          "静岡県",
          "愛知県",
          "三重県",
          "滋賀県",
          "京都府",
          "大阪府",
          "兵庫県",
          "奈良県",
          "和歌山",
          "鳥取県",
          "島根県",
          "岡山県",
          "広島県",
          "山口県",
          "徳島県",
          "香川県",
          "愛媛県",
          "高知県",
          "福岡県",
          "佐賀県",
          "長崎県",
          "熊本県",
          "大分県",
          "宮崎県",
          "鹿児島",
          "沖縄県"
        ]
        data = data.substring(7, data.length - 3);
        yubinMap = JSON.parse(data);
        var prefectureData = yubinMap[event.jpzip1 + event.jpzip2];
        // mainForm.submission.tmp = {
        //   profilePrefecture: prefectureMap[prefectureData[0] - 1],
        //   profileMunicipalities1: prefectureData[1],
        //   profileMunicipalities2: prefectureData[2]
        // };

        // 要更新表單
        // console.log('emit changePrefecture ',mainForm.submission);
        // form.emit('changePrefecture', event);

        if (prefectureMap && prefectureData) {
          mainForm.submission.data.profilePrefecture = prefectureMap[prefectureData[0] - 1];
          mainForm.submission.data.profileCity = prefectureData[1] + prefectureData[2];
          var submission = { data: mainForm.submission.data };
          form.submission = submission;
        } else {
          // 找不到
        }

      }
    }
  });
  // return fetch('https://yubinbango.github.io/yubinbango-data/data/' + event.jpzip1 + '.js', {
  //   // headers: {
  //   //   'content-type': 'application/json'
  //   // },
  //   method: 'GET',
  //   mode: 'no-cors',
  // })
  // .then(response => {
  //     console.log('response ', response);
  //     response.text().then((text) => {
  //       console.log(text);
  //     });
  //   })
});