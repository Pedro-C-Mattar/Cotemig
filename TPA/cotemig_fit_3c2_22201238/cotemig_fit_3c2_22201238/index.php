<!DOCTYPE html>
<html>
<head>
    <title>CRUD de USUARIO</title>
</head>
<body>
    <h1>Lista de USUARIO - 22201238 - Pedro Mattar - 3C2 - nº 32</h1>
    <a href="cadastro_aluno.php">Adicionar Novo Usuario</a><br><br>
    <?php
        require ('conexao.php');
        echo '<br><br><br>';
        // Função para listar todos os registros do banco de dados
        function listarRegistros($conexao) {
        $sql = "SELECT * FROM aluno";
        $stmt = $conexao->query($sql);
        return $stmt->fetchAll(PDO::FETCH_ASSOC);
        }
        // Listar registros
        $registros = listarRegistros($conexao);
            // Exibindo os dados em uma tabela
            echo "<table border='1'>
                <tr>
                    <th>idAluno</th>
                    <th>nome</th>
                    <th>email</th>
                    <th>sexo</th>
                    <th>endereco</th>
                    <th>numero</th>
                    <th>complemento</th>
                    <th>bairro</th>
                    <th>cidade</th>
                    <th>estado</th>
                    <th>modalidade</th>
                </tr>";
            foreach ($registros as $registro) {
                echo "<tr>";
                echo "<td>" . $registro['idAluno'] . "</td>";
                echo "<td>" . $registro['nome'] . "</td>";
                echo "<td>" . $registro['email'] . "</td>";
                echo "<td>" . $registro['sexo'] . "</td>";
                echo "<td>" . $registro['endereco'] . "</td>";
                echo "<td>" . $registro['numero'] . "</td>";
                echo "<td>" . $registro['complemento'] . "</td>";
                echo "<td>" . $registro['bairro'] . "</td>";
                echo "<td>" . $registro['cidade'] . "</td>";
                echo "<td>" . $registro['uf'] . "</td>";
                echo "<td>" . $registro['modalidade'] . "</td>";
                echo "<td>
                    <a href='edit.php?idAluno=" . $registro['idAluno'] . "'>Editar</a>
                    <a href='deletar_dados.php?idAluno=" . $registro['idAluno'] . "'>Excluir</a>
                </td>";
                }
                echo "</tr>";
            echo "</table>";
    ?>
</body>
</html>
