let FNinput = document.getElementById("fName");
let LNinput = document.getElementById("lName");
let Ainput = document.getElementById("ageInt");
let SubBtn = document.getElementById("btn");

let port = "59872";

let postMethod = async () => {
    let url = "http://localhost:" + port + "/api/users";
    let user = { firstName: FNinput.value, lastName: LNinput.value, age: Ainput.value }
    await fetch(url, {
        method: 'POST',
        body: JSON.stringify(user)
    })
}

SubBtn.addEventListener("click", postMethod);
