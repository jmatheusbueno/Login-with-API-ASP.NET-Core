let userRequest;

console.log("main.js Ok")

function Connection()
{   
    //Visual Studio URL
    return "https://localhost:44375/v1/users"
    
    //Visual Studio Code URL
    //return "https://localhost:5001/v1/users"
}

function Login(){
    console.log("Login() ok")
    let url = Connection()
    let username = document.getElementById('username').value
    let password = document.getElementById('password').value 

}

function Get(url)
{
    console.log("Get() ok")
    let request = new XMLHttpRequest();
    request.open("GET", url, false);
    request.send();
    return request.responseText
}

function CreateAccount(){
    console.log("CreateAccount ok")
    let url = Connection()
    let username = document.getElementById('username').value
    let password = document.getElementById('password').value 

    body = {
        "Username" : username,
        "Password" : password
    }

    Post(url, body)
}

function Post(url, body){
    console.log("Post ok")
    let request = new XMLHttpRequest()
    request.open("POST", url, true)
    request.setRequestHeader("Content-type", "application/json")
    request.send(JSON.stringify(body))

    request.onload = function() {
        console.log(this.responseText)
    }

    return request.responseText
}