


const validateNplat = (value) => {

};


const messageSlide = (message, time) => {
    document.querySelector('.message-slide').style.top = '0';
    document.querySelector('.message-slide').innerText = message;

    setTimeout(() => {
        document.querySelector('.message-slide').style.top = '-5rem';
    }, time);
};