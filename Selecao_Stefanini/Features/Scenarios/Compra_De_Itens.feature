Feature: Compra de itens

@RealizarCompra
Scenario: Realizar compra
	Given que estou na tela home
	When adiciono itens no carrinho
	And finalizo minha compra
	Then valido que minha compra foi finalizada com sucesso

@ReabrirCompraParaAdicionarItens
Scenario: Reabrir compra finalizada e adicionar mais 3 itens
	Given que estou na tela home
	When adiciono itens no carrinho
	And acesso a tela para finalizar minha compra
	And volto para tela home
	Then incluo mais itens no carrinho
	When finalizo minha compra
	Then valido que minha compra foi finalizada com sucesso

@MyWhishlistComItens
Scenario: Adicionar item My WishList
	Given que estou na tela home
	When realizo login
	And adiciono itens na my wishlist
	And faco o log off
	And valido que fui rediricionado para a pagina home
	And realizo login
	Then valido que estou na tela da my wishlist


