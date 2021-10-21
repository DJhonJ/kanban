(function () {
    'use strict';
    var krequest = function () {};

    krequest.post = function ({ typeHttp, data }) {
        return new Promise((resolve, reject) => {
            try {
                const request = new XMLHttpRequest();

                if (!request) {
                    console.log(new Error('el navegador no soporta XmlHttpRequest'));
                    return;
                }

                request.open(typeHttp, window.location.pathname, true);

                request.onloadstart = function () {
                    console.log('onloadstart');
                };

                request.onreadystatechange = function () {
                    if (request.readyState === XMLHttpRequest.DONE) {
                        if (request.status === 200) {
                            //console.log(request.response);
                            //resolve(JSON.parse(request.response));
                            resolve(JSON.parse(request.response));
                        }
                        else {
                            //console.log('problemas con la peticion');
                            reject('problemas con la request');
                        }
                    }
                };

                request.onprogress = function () {
                    console.log('onprogress');
                };

                request.onload = function () {
                    console.log('onload');
                };

                request.onloadend = function () {
                    console.log('onloadend');
                };

                request.onerror = function () {
                    console.log('onerror');
                };

                request.onabort = function () {
                    console.log('onabort');
                };

                request.setRequestHeader('Cache-Control', 'no-cache'); //para no almacenar en cache la respuesta
                //request.setRequestHeader('Content-Type', 'application/json; charset=UTF-8');
                request.setRequestHeader('Content-Type', 'application/x-www-form-urlencoded; charset=UTF-8');
                //request.setRequestHeader('Content-Type', 'multipart/form-data; charset=UTF-8');

                request.send(parseData(data));
            } catch {
                resolve('problemas con la request kk');
            }
        });
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