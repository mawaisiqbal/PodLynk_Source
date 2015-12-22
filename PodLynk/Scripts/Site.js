$(function () {
    $("#card").flip({ axis: 'y', trigger: 'manual' });
  
});
function btnClicked() {
    $("#card").flip('toggle');
}