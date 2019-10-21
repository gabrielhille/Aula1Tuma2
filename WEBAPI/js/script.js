
$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                $.get("https://viacep.com.br/ws/38402100/json/", function (data, status) {
                    $('input[name="bairro"]').val(data.bairro);
                    $('input[name="cep"]').val(data.cep);
                    $('input[name="logradouro"]').val(data.logradouro);
                    $('input[name="ibge"]').val(data.ibge);
                    $('input[name="unidade"]').val(data.unidade);
                    $('input[name="uf"]').val(data.uf);
                    $('input[name="localidade"]').val(data.localidade);
                    
                });
            }
        );
    }
);
