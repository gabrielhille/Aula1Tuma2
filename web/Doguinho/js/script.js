
var MeuCachorrinhoPadrao = { nome: "Dog", idade: 14, raca: "SRD", Cor: "Amarelo" };
var ListaDeCachorrinhos = [MeuCachorrinhoPadrao];


$('input[type="button"]').click(
    function () {
        MeuCachorrinhoPadrao.nome = $('input[name="nome"]').val();
        MeuCachorrinhoPadrao.idade = $('input[name="idade"]').val();
        MeuCachorrinhoPadrao.raca = $('input[name="raca"]').val();
        MeuCachorrinhoPadrao.coloracao = $('input[name="coloracao"]').val();
        alert("Nome salvo com sucesso");
       
    });
$('input[type="submit"]').click(
    function () {
        var nome = MeuCachorrinhoPadrao.nome;
        var idade = MeuCachorrinhoPadrao.idade;
        var raca = MeuCachorrinhoPadrao.raca;
        var coloracao = MeuCachorrinhoPadrao.coloracao;

        alert(" Nome: " + nome +
            ", Idade: " + idade +
            " anos, Raça: " + raca +
            ", Coloração: " + coloracao +
            ".");
    });