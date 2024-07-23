//PASO UNO. GUARDAR LOS ELEMENTOS DEL FORMULARIO EN VARIABLES
var input_nombre = document.getElementById ("nombre");
var input_email= document.getElementById ("email");
var input_submit = document.getElementById ("enviar");

//PASO DOS. CREAR FUNCION QUE SE EJECUTA CUANDO SE ENVIA EL FORMULARIO
input_submit.addEventListener ("click", enviarForm); 

function enviarForm (event){
    event.preventDefault();
    //PASO TRES QUEDARNOS CON LOS VALORES DE LOS INPUT
    var valor_nombre = input_nombre.value;
    var valor_email = input_email.value;

    //PASO CUATRO y CINCO. OPTENER LOS PLACEHOLDER
    var placeholder_nombre = document.getElementById ("nombre-placeholder");
    placeholder_nombre.innerHTML = valor_nombre;
    var placeholder_email = document.getElementById ("email-placeholder");
    placeholder_email.innerHTML = valor_email;
}

//PASO SEIS. MOSTRAR EL FEEDBACK
elemento_feedback = document.getElementById("feedback");