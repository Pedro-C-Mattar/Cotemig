<?php
require ('conexao.php');

if (isset($_GET["idAluno"])) {
    $id = $_GET["idAluno"];

    // Função para listar todos os registros do banco de dados
    function listarRegistros($conexao, $id) {
        $sql = "SELECT * FROM aluno WHERE idAluno = $id";
        $stmt = $conexao->query($sql);
        return $stmt->fetchAll(PDO::FETCH_ASSOC);
        }
        // Listar registros
        $registros = listarRegistros($conexao, $id);
        foreach ($registros as $registro) {
            if ($registro['idAluno'] == $id) {
                $aux = true;
            }
        }
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Editar</title>
</head>
<body>
    <h1>Editar Aluno</h1>
    <?php if (isset($aux)) : ?>
        <form action="alterar_dados.php" method="post">
            <input type="hidden" name="id" value="<?php echo $registro['idAluno']; ?>">
            <label>Nome:</label><br>
            <input type="text" name="nome" value="<?php echo $registro['nome']; ?>" required>
            <br>
            <label>Email:</label><br>
            <input type="email" name="email" value="<?php echo $registro['email']; ?>" required>
            <br>
            <label>Sexo:</label><br>
            Feminino: <input class=" mx-2 text-end" <?php echo ($registro['sexo'] == 'f')?"checked":"";?> type="radio" name="sexo" value="f">
            Masculino:<input class=" mx-2 text-end" <?php echo ($registro['sexo'] == 'm')?"checked":"";?> type="radio" name="sexo" value="m">
            Outro:    <input class=" mx-2 text-end" <?php echo ($registro['sexo'] == 'o')?"checked":"";?> type="radio" name="sexo" value="o">
            <br>
            <label>Endereço:</label><br>
            <input type="text" name="endereco" value="<?php echo $registro['endereco']; ?>" required>
            <br>
            <label>Numero:</label><br>
            <input type="text" name="numero" value="<?php echo $registro['numero']; ?>" required>
            <br>
            <label>Complemento:</label><br>
            <input type="text" name="complemento" value="<?php echo $registro['complemento']; ?>" required>
            <br>
            <label>Bairro:</label><br>
            <input type="text" name="bairro" value="<?php echo $registro['bairro']; ?>" required>
            <br>
            <label>Cidade:</label><br>
            <input type="text" name="cidade" value="<?php echo $registro['cidade']; ?>" required>
            <br>
            <label>Uf:</label><br>
            <select id="UF" name="uf" class="form-control border border-dark rounded-0 col col-4">
              <option value="AC" <?php $valor = ($registro['uf'] == 'AC')?'selected': ''; echo $valor; ?> >Acre</option>
              <option value="AL" <?php $valor = ($registro['uf'] == 'AL')?'selected': ''; echo $valor; ?> >Alagoas</option>
              <option value="AP" <?php $valor = ($registro['uf'] == 'AP')?'selected': ''; echo $valor; ?> >Amapá</option>
              <option value="AM" <?php $valor = ($registro['uf'] == 'AM')?'selected': ''; echo $valor; ?> >Amazonas</option>
              <option value="BA" <?php $valor = ($registro['uf'] == 'BA')?'selected': ''; echo $valor; ?> >Bahia</option>
              <option value="CE" <?php $valor = ($registro['uf'] == 'CE')?'selected': ''; echo $valor; ?> >Ceará</option>
              <option value="DF" <?php $valor = ($registro['uf'] == 'DF')?'selected': ''; echo $valor; ?> >Distrito Federal</option>
              <option value="ES" <?php $valor = ($registro['uf'] == 'ES')?'selected': ''; echo $valor; ?> >Espírito Santo</option>
              <option value="GO" <?php $valor = ($registro['uf'] == 'GO')?'selected': ''; echo $valor; ?> >Goiás</option>
              <option value="MA" <?php $valor = ($registro['uf'] == 'MA')?'selected': ''; echo $valor; ?> >Maranhão</option>
              <option value="MT" <?php $valor = ($registro['uf'] == 'MT')?'selected': ''; echo $valor; ?> >Mato Grosso</option>
              <option value="MS" <?php $valor = ($registro['uf'] == 'MS')?'selected': ''; echo $valor; ?> >Mato Grosso do Sul</option>
              <option value="MG" <?php $valor = ($registro['uf'] == 'MG')?'selected': ''; echo $valor; ?> >Minas Gerais</option>
              <option value="PA" <?php $valor = ($registro['uf'] == 'PA')?'selected': ''; echo $valor; ?> >Pará</option>
              <option value="PB" <?php $valor = ($registro['uf'] == 'PB')?'selected': ''; echo $valor; ?> >Paraíba</option>
              <option value="PR" <?php $valor = ($registro['uf'] == 'PR')?'selected': ''; echo $valor; ?> >Paraná</option>
              <option value="PE" <?php $valor = ($registro['uf'] == 'PE')?'selected': ''; echo $valor; ?> >Pernambuco</option>
              <option value="PI" <?php $valor = ($registro['uf'] == 'PI')?'selected': ''; echo $valor; ?> >Piauí</option>
              <option value="RJ" <?php $valor = ($registro['uf'] == 'RJ')?'selected': ''; echo $valor; ?> >Rio de Janeiro</option>
              <option value="RN" <?php $valor = ($registro['uf'] == 'RN')?'selected': ''; echo $valor; ?> >Rio Grande do Norte</option>
              <option value="RS" <?php $valor = ($registro['uf'] == 'RS')?'selected': ''; echo $valor; ?> >Rio Grande do Sul</option>
              <option value="RO" <?php $valor = ($registro['uf'] == 'RO')?'selected': ''; echo $valor; ?> >Rondônia</option>
              <option value="RR" <?php $valor = ($registro['uf'] == 'RR')?'selected': ''; echo $valor; ?> >Roraima</option>
              <option value="SC" <?php $valor = ($registro['uf'] == 'SC')?'selected': ''; echo $valor; ?> >Santa Catarina</option>
              <option value="SP" <?php $valor = ($registro['uf'] == 'SP')?'selected': ''; echo $valor; ?> >São Paulo</option>
              <option value="SE" <?php $valor = ($registro['uf'] == 'SE')?'selected': ''; echo $valor; ?> >Sergipe</option>
              <option value="TO" <?php $valor = ($registro['uf'] == 'TO')?'selected': ''; echo $valor; ?> >Tocantins</option>
              <option value="EX" <?php $valor = ($registro['uf'] == 'EX')?'selected': ''; echo $valor; ?> >Estrangeiro</option> 
            </select>
            <br>
            <label>Modalidade:</label><br>
            <select name="modalidade" id="modalidade" class="form-control">
                <option value="pilates"<?php echo ($registro['modalidade'] == 'pilates')?"selected":"";?>>Pilates</option>
                <option value="musculacao"<?php echo ($registro['modalidade'] == 'musculacao')?"selected":"";?>>Musculação</option>
                <option value="natacao"<?php echo ($registro['modalidade'] == 'natacao')?"selected":"";?>>Natação</option>
                <option value="zumba"<?php echo ($registro['modalidade'] == 'zumba')?"selected":"";?>>Zumba</option>
            </select>
            <br><br><br>
            <input type="submit" value="Salvar">
        </form>
    <?php else : ?>
        <p>Usuario não encontrado.</p>
    <?php endif; ?>
</body>
</html>