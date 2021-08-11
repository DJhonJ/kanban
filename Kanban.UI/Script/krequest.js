

const kpost = () => {
    const request = new XMLHttpRequest();

    if (!request) {
        console.log(new Error('el navegador no soporta XmlHttpRequest'));
        return;
    }

    request.onreadystatechange = function (e) {
        if (request.readyState === XMLHttpRequest.DONE) {
            if (request.status === 200) {
                console.log(JSON.parse(request.responseText));
            }
            else {
                console.log('problemas con la peticion');
            }
        }
    };

    request.open('POST', 'Login.aspx/Ingresar', true);
    request.setRequestHeader('Cache-Control', 'no-cache'); //para no almacenar en cache la respuesta
    request.setRequestHeader('Content-Type', 'application/json; charset=utf-8');
    request.send();
};