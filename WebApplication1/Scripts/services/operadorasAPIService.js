angular.module("ListaTelefonica").service("operadorasAPI", function ($http, config){
	
	this.getOperadoras = function(){

		return $http.get(config.baseUrl + "Operadora");

	};

});