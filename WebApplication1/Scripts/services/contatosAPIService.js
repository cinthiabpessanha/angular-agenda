angular.module("ListaTelefonica").factory("contatosAPI", function($http, config)
{
	var _getContatos = function(){
	
		return $http.get(config.baseUrl + "Contato");

	};

	var _saveContato = function(contato){

		return $http.post(config.baseUrl + "Contato", contato);

	};

	return{

		getContatos: _getContatos,
		saveContato: _saveContato

	};

});