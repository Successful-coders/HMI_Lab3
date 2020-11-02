<?php
$data = $_POST;
if (isset($data['do_lofin']))
{
    $user = R::find('users', 'login=?', array($data['login']));
    if ($user)
    {
        
    }
}
?>

<form action="loginb.php" method="POST">
        <fieldset>

        <legend>Авторизация</legend>

        <p class="login"><label for="name">Логин</label>
        <input type="text" name="login" value = "<?php echo?>">
        </p>

        <p><label for="pasword">Пароль</label>
        <input type="text" id="pasword" >
        </p>

        </fieldset>
        <p><input type="submit" name="do_login" value="Авторизироваться"></p>
</form>