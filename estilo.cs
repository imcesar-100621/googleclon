/* Estilos generales */
body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #f2f2f2;
}

/* Estilos del header y la barra de navegación */
header {
    background-color: #ffffff;
    padding: 10px 20px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.New-right-section {
    list-style-type: none;
    margin: 0;
    padding: 0;
    display: flex;
    align-items: center;
}

.New-right-section li {
    margin-right: 15px;
}

.New-right-section li:last-child {
    margin-right: 0;
}

/* Estilos del logo de Google */
.Main-Logo {
    text-align: center;
    margin-top: 50px;
}

.Main-Logo img {
    width: 272px; /* Tamaño original del logo de Google */
}

/* Estilos del input de búsqueda y el botón */
.Main-input {
    text-align: center;
    margin-top: 20px;
}

.main-input-container {
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: #ffffff;
    border: 1px solid #dfe1e5;
    border-radius: 24px;
    padding: 10px;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
}

.main-input-container input[type="text"] {
    border: none;
    outline: none;
    padding: 10px 15px;
    width: 500px; /* Ajusta el ancho del input según sea necesario */
    font-size: 16px;
}

.main-input-container input[type="text"]:focus {
    box-shadow: 0 0 8px rgba(81, 203, 238, 0.6);
}

.main-input-container .search-icon {
    background-image: url('https://www.gstatic.com/images/icons/material/system/2x/search_black_24dp.png');
    background-repeat: no-repeat;
    width: 24px;
    height: 24px;
    margin-right: 10px;
}

.main-input-container .micro-icon {
    background-image: url('https://www.gstatic.com/images/icons/material/system/2x/mic_none_black_24dp.png');
    background-repeat: no-repeat;
    width: 24px;
    height: 24px;
    display: inline-block;
    margin-left: 10px;
    cursor: pointer;
}

/* Estilos de los botones */
button {
    background-color: #f8f9fa;
    border: 1px solid #f8f9fa;
    color: #3c4043;
    padding: 10px 20px;
    font-size: 14px;
    cursor: pointer;
    margin-right: 10px;
    border-radius: 4px;
}

button:hover {
    background-color: #f0f0f0;
    border: 1px solid #c6c6c6;
}

/* Estilos del footer */
footer {
    background-color: #f2f2f2;
    padding: 20px;
    text-align: center;
}

.footer-left, .footer-right {
    list-style-type: none;
    margin: 0;
    padding: 0;
}

.footer-left li, .footer-right li {
    display: inline-block;
    margin-right: 10px;
}

.footer-left li:last-child, .footer-right li:last-child {
    margin-right: 0;
}
