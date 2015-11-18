	
		
		angular.module("ListaTelefonica").controller("ListaTelefonicaController", function ($scope, $filter, operadorasAPI, contatosAPI, serialGenerator) {
			
			$scope.app = "Lista Telefonica";
		
			$scope.contatos = []; 

			$scope.operadoras = [];



			var carregarContatos = function()
			{

				contatosAPI.getContatos().success(function(data, status)
				{
					$scope.contatos = data;
				});

			};

			var carregarOperadoras = function()
			{

				operadorasAPI.getOperadoras().success(function(data, status)
				{
					$scope.operadoras = data;
				});

			};

			$scope.adicionarContato = function(contato){



				contato.serial = serialGenerator.generate();
				contato.data = new Date();
	
				$scope.contatos.push(angular.copy(contato));
				delete $scope.contato;
				$scope.contatoForm.$setPristine();

			};

			$scope.removerContatos = function(contatos){

				$scope.contatos = contatos.filter(function(contato){

					if (!contato.selecionado) return contato;
			
				});

			};


			$scope.isContatoSelecionado = function(contatos){

				return contatos.some(function(contato){

						return contato.selecionado;
				});


			};

			$scope.ordenarPor = function(campoOrdenacao){

				$scope.criterioDeOrdenacao = campoOrdenacao;
				$scope.direcaoOrdenacao = !$scope.direcaoOrdenacao;

			};
		carregarContatos();
		carregarOperadoras();

		});