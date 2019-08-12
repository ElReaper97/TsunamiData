$(document).ready(function () {
    $('#Table1').hide();
    $('button').click(function () {
        $('#Table1').DataTable();
        $('#Table1').show();
    });
});