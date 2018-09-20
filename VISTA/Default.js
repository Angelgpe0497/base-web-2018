$(document).ready(function () {
   

    VISTA.servicios.wsPersonas.getAll(onComplete_cargarlista);
    
});

debugger;

function enviarDatos () {

    alert("a");
    var data = $('input').serialize();
    alert(data);
    alert(
        "The following data would have been submitted to the server: \n\n" +
        data.substr(0, 120) + '...'
    );
    return false;
}

function onComplete_cargarlista(response) {

    //alert("onComplete_cargarlista + " + response);
    var dataSet = JSON.parse(response);

    tabla = $('#example').dataTable({
        data: dataSet,
        columns: [

            { title: "Id", data: "id", render: $.fn.dataTable.render.text() },
            { title: "Nombre", data: "nombre", render: $.fn.dataTable.render.text() },
            { title: "Calif", data: null, 
            render: function (data, type, row) {
                return '<input type="text" value="1" />';
            }
            }
            
        ]
        

    });
}