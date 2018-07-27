Feature: Compra de itens

#@RealizarCompra
#Scenario: Realizar compra
#	Given que estou na tela home
#	When adiciono itens no carrinho
#	And finalizo minha compra
#	Then valido que minha compra foi finalizada com sucesso

#@ReabrirCompraParaAdicionarItens
#Scenario: Reabrir compra finalizada e adicionar mais 3 itens
#	Given que estou na tela home
#	When adiciono itens no carrinho
#	And acesso a tela para finalizar minha compra
#	And volto para tela home
#	Then incluo mais itens no carrinho
#	And finalizo minha compra
#	And valido que minha compra foi finlizada com sucesso
#
@MyWhishlistComItens
Scenario: Esqueci senha
	Given que estou na tela home
	When adiciono itens na my wishlist
	When faco o log off
	And valido que fui rediricionado para a pagina home
	And volto para tela de login
	And insiro meu usuario e senha
	And clico no botao Sign in
	Then valido que estou na tela da my wishlist


