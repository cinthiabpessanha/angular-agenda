angular.module("ListaTelefonica").filter("filtro", function(){
	
	return function(input){

		var arrayNomes = input.split(" ");

		var nomesFormatados = nomes.map(function(nome){

			return nome.toLowerCase().charAt(0).toUpperCase();

		});

		return nomesFormatados.join(",");

	};


});