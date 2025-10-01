<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>cotemig_fit_22201238</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
</head>
<body>
    <div class="container">
    <h3>Cadastro aluno:</h3>
    <form action="inserir_dados.php" method="post">
        <div class="form-group">
            <label for="exampleInput">Nome</label>
            <input type="text" class="form-control" required name="nome" id="Nome" placeholder="informe o nome">
            <label for="exampleInputEmail1">Email</label>
            <input type="email" class="form-control" required name="email" id="email" placeholder="informe o email">
        </div>

        <div class="form-check">
            <label class="form-check-label" for="flexCheckDefault1">Sexo:</label><br>
            <label class="form-check-label" for="flexCheckDefault1">Masculino:</label>
            <input class="form-check-input" type="radio" name="sexo" value="m" id="masculino">
            <label class="form-check-label" for="flexCheckDefault1">Feminino:</label>
            <input class="form-check-input" type="radio" name="sexo" value="f" id="feminino">
            <label class="form-check-label" for="flexCheckDefault1">Outro:</label>
            <input class="form-check-input" type="radio" name="sexo" value="o" id="outro">
        </div>

        <label for="exampleinput">Endereço</label>
        <input type="text" class="form-control" required name="endereco" id="endereco" placeholder="informe o endereço">
        <label for="exampleinput">Numero</label>
        <input type="int" class="form-control" required name="numero" id="numero" placeholder="informe o numero">
        <label for="exampleinput">Complemento</label>
        <input type="text" class="form-control" required name="complemento" id="complemento" placeholder="informe o complemento">
        <label for="exampleinput">Bairro</label>
        <input type="text" class="form-control" required name="bairro" id="bairro" placeholder="informe o bairro">
        <label for="exampleinput">Cidade</label>
        <input type="text" class="form-control" required name="cidade" id="cidade" placeholder="informe a cidade">

        <label name="uf" for="exampleinput">UF:</label><br>
        <select id="estado" name="estado">
            <option value="AC">Acre</option>
            <option value="AL">Alagoas</option>
            <option value="AP">Amapá</option>
            <option value="AM">Amazonas</option>
            <option value="BA">Bahia</option>
            <option value="CE">Ceará</option>
            <option value="DF">Distrito Federal</option>
            <option value="ES">Espírito Santo</option>
            <option value="GO">Goiás</option>
            <option value="MA">Maranhão</option>
            <option value="MT">Mato Grosso</option>
            <option value="MS">Mato Grosso do Sul</option>
            <option value="MG">Minas Gerais</option>
            <option value="PA">Pará</option>
            <option value="PB">Paraíba</option>
            <option value="PR">Paraná</option>
            <option value="PE">Pernambuco</option>
            <option value="PI">Piauí</option>
            <option value="RJ">Rio de Janeiro</option>
            <option value="RN">Rio Grande do Norte</option>
            <option value="RS">Rio Grande do Sul</option>
            <option value="RO">Rondônia</option>
            <option value="RR">Roraima</option>
            <option value="SC">Santa Catarina</option>
            <option value="SP">São Paulo</option>
            <option value="SE">Sergipe</option>
            <option value="TO">Tocantins</option>
            <option value="EX">Estrangeiro</option>
        </select> <br>

        <label for="exampleInput">Modalidade:</label>
        <select name="modalidade" id="modalidade" class="form-control">
            <option value="pilates">Pilates</option>
            <option value="musculacao">Musculação</option>
            <option value="natacao">Natação</option>
            <option value="zumba">Zumba</option>
        </select>

        <button type="submit" class="btn btn-primary">Enviar</button>
        <button type="reset" class="btn btn-danger">Limpar</button>
    </form>
    </div>
</body>
</html>