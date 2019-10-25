//carregando doocumento
$(document).ready(function () {
    //Adicionando uma função ao click do botao
    $('#Button1').click(function () {
        //conectando com o api web
        $.getJSON("https://viacep.com.br/ws/RS/Porto%20Alegre/all/json/", function (data) {
            $.each(data, function (key, value) {
                //criamos uma variavel que ira armazenar a informaçãp
                var templateContent = "" ;
                //iniciamos um separador de informações
                templateContent += "{";
                //outro laço para repitir cada informação
                $.each(value, function (key, value) {
                    //adicionamos todas as nossas informaçoes
                    templateContent += key + ":" + value + ",";

                });
                //finalizamos nosso objeto
                templateContent += "},";
                //adicionamos ao nosso campo de texto
                $('#TextArea1').append(
                    templateContent + "\r\n"
                );
            });
                               
        });
    });
});