import '../../app/css-classes/home.css';
import Image from 'next/image';
import FloppaIcon from '../../images/floppa.svg';

// const FloppaIcon = require('../../images/floppa.svg');

const StartPage = () => {
    const mainButtonRu: string = 'Главная';
    const welcomeStringRu: string = 'Добро пожаловать в мессенджер Floppa';
    const signUpRu: string = 'Зарегистрироваться';
    const signInRu: string = 'Войти в аккаунт';
  return (
    <div className='flex flex-col h-screen'>
      <header className="flex w-full justify-center content-center flex-wrap header">
        <nav className='flex flex-row'>
          <button className='header-button' >
            <span className='text-[1.5rem]'>
              {mainButtonRu}
            </span>
          </button>
        </nav>
      </header>
    <div className='flex flex-1 overflow-hidden'>
      <div className='flex justify-center items-center w-1/2'>
        <FloppaIcon />
      </div>
      <div className='w-1/2 flex items-center justify-center'>
        <div className='flex flex-col items-center justify-center'>
          <span className='text-[2rem] mb-[1rem] text-col'>
            {welcomeStringRu}
          </span>
          <div>
            <button className='main-button'>
              <span className='text-[1.5rem] text-col'>
                {signUpRu}
              </span>
            </button>
          </div>
          <div>
            <button className='main-button'>
              <span className='text-[1.5rem] text-col'>
                {signInRu}
              </span>
            </button>
          </div>
        </div>
      </div>
      
    </div>
    </div>
  );

}

export default StartPage;