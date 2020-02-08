var checksumdigits = new Array("2", "4", "8", "5", "10", "9", "7", "3", "6");
var resultdigits = new Array();
var checksum = 0;
var cd = 0;

function checkEGN(n) {
    checksum = 0;

    if (checkLength(n) != 0) { return (1) };

    for (i = 0; i < 9; i++) {
        checksum = checksum + (checksumdigits[i] * n.charAt(i));
    }
    cd = getmodulo(checksum, 11);

    if (cd == 10) { cd = 0 }

    if ((cd != n.charAt(9))) {
        alert("Грешен ЕГН!");
        return (1);
    }
    else {
        var resstr = "";
        var sex = "";

        if (getmodulo(n.substr(8, 1), 2) != 0) {
            sex = "Жена, родена във ";
        }
        else {
            sex = "Мъж, роден във ";
        }
    }

    resstr = "" + sex + getBirthPlace(n.substr(6, 3));
    {
        //alert(resstr);
        document.getElementById("result").innerHTML = "<div style='padding:2%;' class='alert alert-success'>"+
        "<strong>ЕГН е правилен!</strong> "+resstr+""+
        "</div>";

    }

}

function checkLength(n) {

    if (n.length != 10) {
        alert("Въведете 10 цифри!");
        return (1);
    }

    else { return (0) }
}

function getmodulo(a, b) {
    var x = 0;
    var y = 0;

    x = Math.floor(a / b);
    y = x * b;
    return (a - y);
}

function getBirthPlace(bp) {
    if (bp < 044) { return ("Благоевград") }
    if (bp < 094) { return ("Бургас") }
    if (bp < 140) { return ("Варна") }
    if (bp < 170) { return ("Велико Търново") }
    if (bp < 184) { return ("Видин") }
    if (bp < 218) { return ("Враца") }
    if (bp < 234) { return ("Габрово") }
    if (bp < 282) { return ("Кърджали") }
    if (bp < 302) { return ("Кюстендил") }
    if (bp < 320) { return ("Ловеч") }
    if (bp < 342) { return ("Монтана") }
    if (bp < 378) { return ("Пазарджик") }
    if (bp < 396) { return ("Перник") }
    if (bp < 436) { return ("Плевен") }
    if (bp < 502) { return ("Пловдив") }
    if (bp < 528) { return ("Разград") }
    if (bp < 556) { return ("Русе") }
    if (bp < 576) { return ("Силистра") }
    if (bp < 602) { return ("Сливен") }
    if (bp < 624) { return ("Смолян") }
    if (bp < 722) { return ("София-град") }
    if (bp < 752) { return ("София-окръг") }
    if (bp < 790) { return ("Стара Загора") }
    if (bp < 822) { return ("Добрич") }
    if (bp < 844) { return ("Търговище") }
    if (bp < 872) { return ("Хасково") }
    if (bp < 904) { return ("Шумен") }
    if (bp < 926) { return ("Ямбол") }
    if (bp < 1000) { return ("в чужбина") }
}
