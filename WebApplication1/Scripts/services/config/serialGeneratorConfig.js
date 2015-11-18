//só é possível referenciar no config um provider - permite fazer serviços configuráveis

angular.module("ListaTelefonica").config(function(serialGeneratorProvider)
{

	serialGeneratorProvider.setLength(100);

});