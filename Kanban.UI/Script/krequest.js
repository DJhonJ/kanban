(function () {
    'use strict';
    var krequest = function () {};

    krequest.post = function ({ typeHttp, data }) {
        const request = new XMLHttpRequest();
        
        if (!request) {
            console.log(new Error('el navegador no soporta XmlHttpRequest'));
            return;
        }

        request.open(typeHttp, window.location.pathname, true);

        request.onreadystatechange = function () {
            if (request.readyState === XMLHttpRequest.DONE) {
                if (request.status === 200) {
                    console.log(request.response);
                }
                else {
                    console.log('problemas con la peticion');
                }
            }
        };

        request.setRequestHeader('Cache-Control', 'no-cache'); //para no almacenar en cache la respuesta
        //request.setRequestHeader('Content-Type', 'application/json; charset=UTF-8');
        request.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded; charset=UTF-8');
        //request.setRequestHeader('Content-Type', 'multipart/form-data; charset=UTF-8');

        request.send(parseData(data));
    };

    const parseData = (data) => {
        let stringData = [];
        for (let item in data) {
            let name = item !== 'action' ? `${item}_param` : item;
            stringData.push(`${name}=` + data[item]);
        }

        return stringData.join('&');
    };

    window.krequest = krequest;
})();