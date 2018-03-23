//Check of Specyfic Todos By clicking
$("ul").on("click","li",function(){
	$(this).toggleClass("completed")
});

//click on x o delate todo
$("ul").on("click","span",function(event){
	$(this).parent().fadeOut(500,function(){
		this.remove();
	})

	event.stopPropagation();
});

$("input[type='text']").keypress(function(event){
	if(event.which===13){
		toDoText=$(this).val();
		$(this).val("");
		$("ul").append("<li><span><i class='fa fa-trash' aria-hidden='true'></i></span> "+toDoText+"</li>");

	};
});

$(".icon-plus").click(function(){
	$("input[type='text']").fadeToggle();
});