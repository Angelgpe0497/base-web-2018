$(document).ready(function () {
    
    VISTA.servicios.wsPersonas.getAll(onComplete_cargarlista);
    
});

function onComplete_cargarlista(response) {

    //alert("onComplete_cargarlista + " + response);
    var dataSet = JSON.parse(response);

    tabla = $('#example').dataTable({
        data: dataSet,
        columns: [

            { title: "Id", data: "id", render: $.fn.dataTable.render.text() },
            { title: "Nombre", data: "nombre", render: $.fn.dataTable.render.text() },
            
        ]
        

    });
}