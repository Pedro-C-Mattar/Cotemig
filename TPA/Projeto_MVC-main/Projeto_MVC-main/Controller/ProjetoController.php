<?php
require_once 'model/Projeto.php';
class ProjetoController
{
    public function all()
    {
        $obj = new Projeto();
        $projetos = $obj->all();
        require_once 'view/Projeto_all.php';

    }
    public function create(){
        $obj = new Projeto();
        if( isset($_POST['nome']))
        {
            $obj->setNome($_Post['nome']);
            $obj->setDuracao($_Post['duracao']);
            $obj->create();
            $projeto = $obj-> read();
        }
        else{
            $projeto = (object)[
                'id'=> null,
                'nome'=> '',
                'duracao'=>'',
            ];
        }
        require_once 'view/Projeto_create.php';
    }
    public function read(){
        $obj = new Projeto();
        $obj->setId($_GET['id']);
        $projeto = $obj->read();
        require_once 'view/Projeto_update.php'
    }
    public function update(){
        $obj = new Projeto();
        $obj->serId($_GET['id']);
        if(issert($_Post['nome'])){
            $obj->setNome($_Post['nome']);
            $obj->setDuracao($_Post['duracao']);
            $obj->update();
        }
        $projeto = $obj->read();
        require_once "view/Projeto_update.php"
    }
        public function delete(){
            $obj = new Projeto();
            $obj->setID($_GET['id']);
            $obj->delete();
            header("Location: ./");
        }   

}