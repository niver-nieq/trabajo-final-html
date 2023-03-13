(() => {
  const refs = {
    openModalBtn: document.querySelector('[data-modal-header-open]'),
    closeModalBtn: document.querySelector('[data-modal-header-close]'),
    closeMenuBtnOne: document.querySelector('.closeMenuBtnOne'),
    closeMenuBtnTwo: document.querySelector('.closeMenuBtnTwo'),
    closeMenuBtnThree: document.querySelector('.closeMenuBtnThree'),
    closeMenuBtnFour: document.querySelector('.closeMenuBtnFour'),
    closeMenuBtnFive: document.querySelector('.closeMenuBtnFive'),
    closeMenuBtnButtom: document.querySelector('.closeMenuBtnButtom'),
    modal: document.querySelector('[data-modal-header]'),
  };

  refs.openModalBtn.addEventListener('click', toggleModal);
  refs.closeModalBtn.addEventListener('click', toggleModal);
  refs.closeMenuBtnOne.addEventListener('click', toggleModal);
  refs.closeMenuBtnTwo.addEventListener('click', toggleModal);
  refs.closeMenuBtnThree.addEventListener('click', toggleModal);
  refs.closeMenuBtnFour.addEventListener('click', toggleModal);
  refs.closeMenuBtnFive.addEventListener('click', toggleModal);
  refs.closeMenuBtnButtom.addEventListener('click', toggleModal);

  function toggleModal() {
    refs.modal.classList.toggle('is-hidden');
  }
})();
