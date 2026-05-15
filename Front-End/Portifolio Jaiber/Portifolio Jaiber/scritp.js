const toggle = document.getElementById('darkModeToggle');
toggle.addEventListener('click', () => {
  document.body.classList.toggle('dark-mode');
  toggle.textContent = document.body.classList.contains('dark-mode') ? '☀️' : '🌙';
});

const telInput = document.getElementById('telefone');
telInput.addEventListener('input', (e) => {
  let value = e.target.value.replace(/\D/g, ''); // mantém apenas números
  if (value.length > 13) value = value.slice(0, 13);
  if (value.length === 0) {
    e.target.value = '';
    return;
  }
  let formatted = '';
  if (value.length <= 2) {
    formatted = '+' + value;
  } else if (value.length <= 4) {
    formatted = '+' + value.substring(0, 2) + ' (' + value.substring(2);
  } else if (value.length <= 9) {
    formatted = '+' + value.substring(0, 2) + ' (' + value.substring(2, 4) + ') ' + value.substring(4);
  } else if (value.length <= 13) {
    formatted = '+' + value.substring(0, 2) + ' (' + value.substring(2, 4) + ') ' + value.substring(4, 9) + '-' + value.substring(9);
  }
  e.target.value = formatted;
});

/*Animate on Scroll e Typing*/
document.addEventListener("DOMContentLoaded", function() {
  // Inicializa o AOS
  AOS.init({
    duration: 1500,
    once: true,
    offset: 120
  });

  // Inicializa o efeito de digitação
  const typed = new Typed("#typed", {
    strings: [
      "Desenvolvedor Full Stack",
      "Criador de Soluções Digitais",
      "Apaixonado por Tecnologia"
    ],
    typeSpeed: 100,    // velocidade de digitação
    backSpeed: 60,    // velocidade de apagar
    backDelay: 1000,  // tempo antes de apagar
    loop: true         // repetir para sempre
  });
});