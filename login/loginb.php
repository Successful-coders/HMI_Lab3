<?php
$admin = "admin";
$pasword = "6666";
$data = $_POST;
$ret = false;
if (isset($data['do_login']))
{
  $errors = array();
        if($data['login']==$admin)
        {
            if($data['password']==$pasword)
            {
                //echo '<div/ style = "color: green;">Вы авторизованы</div>';
                $ret = true;
                //header('Content-Type: application/json');
                echo json_encode($ret);
            }
            else
            {
                echo json_encode($ret);
            }
        }
        else
        {
            echo json_encode($ret);
        }
}
?>

<form action="loginb.php" method="POST">
        <fieldset>

        <legend>Авторизация</legend>

        <p class="login"><label for="name">Логин</label>
        <input type="text" name="login" value="<?php echo @$data['login']; ?>">
        </p>

        <p><label for="pasword">Пароль</label>
        <input type="password" name="password" value="<?php echo @$data['password']; ?>" >
        </p>

        </fieldset>
        <p><input type="submit" name="do_login" value="Авторизироваться"></p>
</form>