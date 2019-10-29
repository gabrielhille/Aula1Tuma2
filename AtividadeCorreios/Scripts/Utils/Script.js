$(document).ready(function () {
    $('input[id=Submit1]').click(function () {

        var codigo = $('input[name="codigo"]').val();
        var senha = ``;
        var servicos = $('select[name="servicos"]').val();
        var cepori = $('input[name="cepori"]').val();
        var cepdes = $('input[name="cepdes"]').val();
        var peso = $('input[name="peso"]').val();
        var comprimento = $('input[name="comprimento"]').val();
        var formato = '1';
        var altura = $('input[name="altura"]').val();
        var largura = $('input[name="largura"]').val();
        var diametro = $('input[name="diametro"]').val();
        var maopropria = 'S';
        var valordeclarado = $('input[name="valordeclarado"]').val();
        var avisorecebimento = 'S';

        var urlMontada = "http://usysweb.com.br/api/correiosambev.php?" + "&nCdEmpresa=" + codigo + "&sDsSenha=" + senha + "&nCdServico=" + servicos +
            "&sCepOrigem=" + cepori + "&sCepDestino=" + cepdes + "&nVlPeso=" + peso + "&nCdFormato=" + formato + "&nVlComprimento=" + comprimento + "&nVlAltura=" + altura +
            "&nVlLargura=" + largura + "&nVlDiametro=" + diametro + "&sCdMaoPropria=" + maopropria + "&nVlValorDeclarado=" + valordeclarado + "&sCdAvisoRecebimento=" + avisorecebimento;

         
        $.getJSON(urlMontada, function (tipo) {
            
            alert("O preço desse pedido será: R$ " + tipo.cServico.Valor +
                ", prazo de entrga é de " + tipo.cServico.PrazoEntrega + "Dias"

            );
            
        });       
    });           
});                         
                  
                  