# JogoVelhaAPI

------------------------
Dependência: dotnet versão > 3
https://dotnet.microsoft.com/download/dotnet-core/3.0

------------------------
Build e execução no VSCode: Restaurar as dependências

------------------------
Testes realizados com Postman

1)Gera uma instância do jogo (Passando um Json vazio {})
https://localhost:5001/game

2)Realizar um movimento (Passando um Json com o guid do jogo no link e no id
https://localhost:5001/game/fe4c77af-652f-49a4-a95c-874e1c64639e/movement

{
	"id" : "fe4c77af-652f-49a4-a95c-874e1c64639e",
	"player": "X",
	"position": {
	"x": 0,
	"y": 2}
}

------------------------
Existem 2 imagens na raiz caso fique alguma dúvida em relação ao post

