import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import 'bootstrap/dist/css/bootstrap.min.css';

const AddClient = () => {
  const [newClient, setNewClient] = useState({
    firstName: '',
    lastName: '',
    email: '',
    phoneNumber: '',
    password: '',
    id: '',
  });

  const navigate = useNavigate();

  const handleChange = (e) => {
    const { name, value } = e.target;
    setNewClient({ ...newClient, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    fetch('http://localhost:5124/api/clients', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(newClient)
    })
      .then((res) => res.json())
      .then((data) => {
        navigate("/clients");
      })
      .catch((error) => console.error('Error adding client:', error));
  };

  return (
    <div className="container-fluid" style={{ backgroundColor: '#f9ecd2', minHeight: '100vh', display: 'flex', justifyContent: 'center', alignItems: 'center' }}>
      <div className="container" style={{ backgroundColor: '#ffffff', padding: '20px', borderRadius: '8px', boxShadow: '0 0 10px rgba(0,0,0,0.1)', maxWidth: '600px' }}>
        <h2 className="mb-4">Add New Client</h2>
        <Form onSubmit={handleSubmit}>
          <Form.Group controlId="formID">
            <Form.Label>ID</Form.Label>
            <Form.Control
              type="text"
              name="id"
              value={newClient.id}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group controlId="formFirstName">
            <Form.Label>First Name</Form.Label>
            <Form.Control
              type="text"
              name="firstName"
              value={newClient.firstName}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group controlId="formLastName">
            <Form.Label>Last Name</Form.Label>
            <Form.Control
              type="text"
              name="lastName"
              value={newClient.lastName}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group controlId="formEmail">
            <Form.Label>Email</Form.Label>
            <Form.Control
              type="email"
              name="email"
              value={newClient.email}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group controlId="formPhoneNumber">
            <Form.Label>Phone Number</Form.Label>
            <Form.Control
              type="text"
              name="phoneNumber"
              value={newClient.phoneNumber}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group controlId="formPassword">
            <Form.Label>Password</Form.Label>
            <Form.Control
              type="password"
              name="password"
              value={newClient.password}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Button variant="warning" type="submit" className="mt-3" style={{ backgroundColor: '#edd8c7', borderColor: '#edd8c7' }}>Add Client</Button>
        </Form>
      </div>
    </div>
  );
};

export default AddClient;
