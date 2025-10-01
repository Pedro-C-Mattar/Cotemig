<?php

    class Alerts{
        public static function success($message){
            echo "<div class='alert text-center alert-success' role='alert'>
                $message
            </div>";
        }

        public static function danger($manager){
            echo "<div class='alert text-center alert-danger' roler='alert'>
            $message
            </div>";
        }
    }
?>