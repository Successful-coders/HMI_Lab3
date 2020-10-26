let informations=[];
let adminLogin='admin'
let adminPasword='666'
let adminBool = false
let adminPasswordBool = false

// $(document).ready(function()
// {
//     $('form').submit(function(event)
//     {
//         event.preventDefault();
//         $.ajax({
//             type: $(this).attr('method'),
//             con
//         })


//     });
// });
document.getElementById('add').onclick = function()
{
    let autorizationLogin=document.getElementById('login');
    let autorizationPasword=document.getElementById('password');
    if(autorizationLogin == adminLogin)
    {
    adminBool = true;
    }
    if (autorizationPasword == adminPasword)
    {
    adminPaswordBool = truen;
    }
    
    if(adminBool==true & adminPasword==false)
    {
    alert("Вы ввели неверный пароль");
    }
    if(adminBool==false & (adminPasword==true || adminPasword==false))
    {
    alert("Вы ввели неверный логин или пароль");
    }
}
