import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from './HomePage';
import ClientList from './ClientsUI/ClientList';
import AddClient from './ClientsUI/AddClient';
import UpdateClient from './ClientsUI/UpdateClient';
import GownList from './GownsUI/GownsList'; 
import Navbar from 'react-bootstrap/Navbar';
import Nav from 'react-bootstrap/Nav';

const App = () => {
  return (
    <Router>
      <div style={{ backgroundColor: '#f9ecd2', minHeight: '100vh', padding: '20px' }}>
        <Navbar bg="light" expand="lg" className="mb-4" style={{ backgroundColor: '#f9ecd2' }}>
          <Navbar.Brand href="/">Bridal Gowns</Navbar.Brand>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="ml-auto">
              <Nav.Link href="/" className="text-dark">Home</Nav.Link>
              <Nav.Link href="/clients" className="text-dark">Clients</Nav.Link>
              <Nav.Link href="/gowns" className="text-dark">Gowns</Nav.Link>
            </Nav>
          </Navbar.Collapse>
        </Navbar>

        <div style={{ display: 'flex', justifyContent: 'center', marginTop: '20px' }}>
          <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/clients/*" element={<ClientList />} />
            <Route path="/clients/add-client" element={<AddClient />} />
            <Route path="/clients/update-client/:id" element={<UpdateClient />} />
            <Route path="/gowns/*" element={<GownList />} />
          </Routes>
        </div>
      </div>
    </Router>
  );
};

export default App;
