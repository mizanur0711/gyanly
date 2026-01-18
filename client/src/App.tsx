import React from 'react';
import { Route, Routes } from 'react-router';
import './App.css';
import HomePage from './pages/HomePage';
import DetailPage from './pages/DetailPage';
import LoginPage from './pages/Login';

function App() {

  return (
    <Routes>
      <Route path="/" element={<HomePage />} />
      <Route path="/detail" element={<DetailPage />} />
      <Route path='/login' element={<LoginPage />} />
    </Routes>
  );
}

export default App;
