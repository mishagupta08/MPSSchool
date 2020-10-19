
$(document).ready(function () {
    $(".preloader").hide();

});

function DownloadFile(file) {
    $(".preloader").show();
    $.ajax({
        url: '/Dashboard/DownloadFile',
        type: 'Post',
        datatype: 'Json',
        async:false,
        data: { "file": file }
    }).done(function (result) {       
        $(".preloader").hide();
    }).fail(function (error) {
        $("#error").html(error.statusText);
        $(".preloader").hide();
    });

    return false;
}

    

  