var sheetThemeLight;
var sheetThemeDark;
var sheetRef = $('#bootstrap-theme');

function loadStyle(file, callback) {
    var newSheet = $('<link rel="stylesheet" type="text/css" href="' + file + '">');

    $('head').append(newSheet);

    newSheet.on('load', function () {
        if (callback && typeof callback === 'function') {
            callback();
        }
    });
}

function changeTheme(cssFile) {
    var newSheet = $('<link rel="stylesheet" type="text/css" href="' + cssFile + '">');
    $('head').append(newSheet);

    //loadStyle(cssFile, function () {
    //    sheetRef.remove();

    //    sheetRef.attr('id', '');
    //    $('head link[href="' + cssFile + '"]').attr('id', 'bootstrap-theme');
    //});
}

function changeThemeAsync(themeOn, themeOff, switchIsActive) {
    var controller = "Application";
    var method = "ChangeTheme";

    var actionController = `/${controller}/${method}?themeOn=${themeOn}&themeOff=${themeOff}&switchIsActive=${switchIsActive}`;
    $.ajax({
        type: "POST",
        url: actionController,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data != null) {
                changeTheme(data.themeOn);
            }
        },
        error: function (error) {
            console.log(error);
        }
    });
}

$(document).ready(function () {
    $('#btn-switch-theme').change(function () {
        if ($(this).is(':checked')) {
            changeThemeAsync(sheetThemeDark, sheetThemeLight, true);
        } else {
            changeThemeAsync(sheetThemeLight, sheetThemeDark, false);
        }
    });
});
