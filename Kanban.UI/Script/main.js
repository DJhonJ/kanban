document.addEventListener('DOMContentLoaded', () => {
    //console.log(document.querySelector('.layout-grid'), window.screen.height)
    //document.querySelector('.layout-grid').style.minHeight = `${window.screen.height}px`;

    setTagMain();
    window.addEventListener('resize', () => {
        setTagMain();
        console.log(0);
    });
});

const validateNplat = (value) => {

};

const setTagMain = () => {
    if (document.querySelector('.layout-grid')) {
        document.querySelector('.layout-grid').style.minHeight = `${document.documentElement.clientHeight}px`;
    }
};

const messageSlide = (message, time) => {
    document.querySelector('.message-slide').style.top = '0';
    document.querySelector('.message-slide').innerText = message;

    setTimeout(() => {
        document.querySelector('.message-slide').style.top = '-5rem';
    }, time);
};