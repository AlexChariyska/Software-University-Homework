(function() {
   $("#btnGenerator").on('click', function ()  {
       var jsonString = [
           {"manufacturer": "BMW", "model": "E92 320i", "year": 2011, "price": 50000, "class": "Family"},
           {"manufacturer": "Porsche", "model": "Panamera", "year": 2012, "price": 100000, "class": "Sport"},
           {"manufacturer": "Peugeot", "model": "305", "year": 1978, "price": 1000, "class": "Family"}
       ];

       $.each(jsonString, function (obj, objItem) {
           var $tr = $('<tr>').append(
               $('<td>').text(objItem.manufacturer),
               $('<td>').text(objItem.model),
               $('<td>').text(objItem.year),
               $('<td>').text(objItem.price),
               $('<td>').text(objItem.class)
           ).appendTo('.table');
       });
   });
}());
