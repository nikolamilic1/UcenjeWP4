import 'bootstrap/dist/css/bootstrap.min.css'
import './App.css'
import NavBarAplikacija from './components/NavBarAplikacija';
import { useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import { RoutesNames } from './constants';
import Pocetna from './pages/Pocetna';
import SmjeroviPregled from './pages/smjerovi/SmjeroviPregled';

function App() {
  


  return (
    <>
       <NavBarAplikacija/>
       <Routes>
        <Route path={RoutesNames.HOME} element={<Pocetna />} />


        <Route path={RoutesNames.SMJER_PREGLED} element={<SmjeroviPregled />} />
       </Routes>
    </>
  )
}

export default App
