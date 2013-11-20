$(function() {
    $("#txtPassword").blur(function() {
        var str = $(this).val();
        if (str.length <= 6) {
            $("#forPassword").text("密码强度：弱");
        }
        else
        {
            $("#forPassword").text("密码强度：强");
        }
    });
});