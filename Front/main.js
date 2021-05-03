console.log("Foi")

function UserGet(url)
{
    let request = new XMLHttpRequest();
    request.open("GET", url, false);
    request.send();
    return request.responseText
}

function Main()
{
    console.log(UserGet("https://localhost:44375/v1/users"))
}

Main()