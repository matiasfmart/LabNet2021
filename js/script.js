$( document ).ready(function() 
{
    submitClick();
    buttonClear();
});

function submitClick()
{
    $('.submit').click(function()
    {
        if( $('.inputTextRequired').val().length == 0 )
        {
            alert('PIP! >.<  Al menos completa el nombre y apellido!');
        }
        else
        {
            $(".formulario-container").fadeOut(500, function(){
                $(".enviado").fadeIn(500);
            });
        }
    });
}

function buttonClear()
{
    $('.clear').click(function()
    {
        limpiarFormulario();
    })
}

function limpiarFormulario() {
    document.getElementById("basicForm").reset();
}
