function signin() {

    var username1 = document.getElementById("usernamesignin");
    var pass1 = document.getElementById("passwordsignin");

    if (username1.value == "") {

        alert("请输入用户名");

    } else if (pass1.value  == "") {

        alert("请输入密码");

    } else if(username1.value == "admin"){

        alert("该用户名已被注册！")
     
    }
	else alert("注册成功！")
}