document.addEventListener('DOMContentLoaded', () => {
    if (document.querySelector('button[data-action]')) {
        document.querySelector('button[data-action]').addEventListener('click', (e) => {
            e.preventDefault();

            krequest.post({ typeHttp: 'POST', data: { ...obtenerData(), action: e.target.dataset.action } });
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