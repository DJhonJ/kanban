document.addEventListener('DOMContentLoaded', () => {
    if (document.querySelector('button[data-action]')) {
        document.querySelector('button[data-action]').addEventListener('click', (e) => {
            e.preventDefault();
            document.body.classList.add('enable-loading');

            krequest.post({ typeHttp: 'POST', data: { ...obtenerData(), action: e.target.dataset.action } })
                .then((response) => {
                    if (response) {
                        switch (response.StringCode) {
                            case 'error':
                                if (response.Message) {
                                    messageSlide(response.Message, 3000);
                                }
                                break;

                            case 'success':
                                if (response.Redirect) {
                                    window.location.href = response.Redirect;
                                    return;
                                }
                                break;
                        }
                    }

                    document.body.classList.remove('enable-loading');
                    console.log(response);
                })
                .catch((message) => {
                    document.body.classList.remove('enable-loading');
                    console.log(message);
                });
        });
    }
});

const obtenerData = () => {
    let data = {};
    document.querySelectorAll('input[data-action-name], select[data-action-name], textarea[data-action-name]').forEach(input => {
        data[input.dataset.actionName] = input.value;
    });

    return data;
};