import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavBarAplikacija from './components/NavBarAplikacija';
import { useState } from 'react';
import { Routes } from 'react-router-dom';
import { RoutesNames } from './constants';
import Pocetna from './pages/Pocetna';

function App() {
  


  return (
    <>
       <NavBarAplikacija/>
       <Routes>
        <Route path={RoutesNames.HOME} element={<Pocetna />} />
       </Routes>
    </>
  )
}

export default App
