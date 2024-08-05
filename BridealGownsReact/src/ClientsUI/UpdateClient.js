import React, { useState, useEffect } from "react";
import { useNavigate, useParams } from 'react-router-dom';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';
import 'bootstrap/dist/css/bootstrap.min.css';

const UpdateClient = () => {
  const [client, setClient] = useState({
    id: '',
    firstName: '',
    lastName: '',
    email: '',
    phoneNumber: '',
    password: '',
  });

  const { id } = useParams();
  const navigate = useNavigate();

  useEffect(() => {
    fetch(`http://localhost:5124/api/clients/${id}`)
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.json();
      })
      .then(data => {
        if (!data) {
          throw new Error('No data found');
        }
        setClient(data);
      })
      .catch(error => console.error('Error fetching client:', error));
  }, [id]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setClient({ ...client, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    const updatedClient = { ...client, id: id }; // Make sure ID is included in the object

    fetch(`http://localhost:5124/api/clients/${id}`, {
      method: 'PUT',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(updatedClient)
    })
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        return response.json();
      })
      .then(data => {
        navigate('/clients');
      })
      .catch(error => console.error('Error updating client:', error));
  };

  return (
    <div className="container-fluid" style={{ backgroundColor: '#f9ecd2', minHeight: '100vh', display: 'flex', justifyContent: 'center', alignItems: 'center' }}>
      <div className="container" style={{ backgroundColor: '#ffffff', padding: '20px', borderRadius: '8px', boxShadow: '0 0 10px rgba(0,0,0,0.1)', maxWidth: '600px' }}>
        <h2 className="mb-4">Update Client</h2>
        <Form onSubmit={handleSubmit}>
          <Form.Group className="mb-3">
            <Form.Label>First Name</Form.Label>
            <Form.Control
              type="text"
              name="firstName"
              value={client.firstName}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group className="mb-3">
            <Form.Label>Last Name</Form.Label>
            <Form.Control
              type="text"
              name="lastName"
              value={client.lastName}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group className="mb-3">
            <Form.Label>Email</Form.Label>
            <Form.Control
              type="email"
              name="email"
              value={client.email}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group className="mb-3">
            <Form.Label>Phone Number</Form.Label>
            <Form.Control
              type="text"
              name="phoneNumber"
              value={client.phoneNumber}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Form.Group className="mb-3">
            <Form.Label>Password</Form.Label>
            <Form.Control
              type="password"
              name="password"
              value={client.password}
              onChange={handleChange}
              required
              style={{ backgroundColor: '#edd8c7', borderColor: '#e5b79e' }}
            />
          </Form.Group>
          <Button variant="warning" type="submit" style={{ backgroundColor: '#edd8c7', borderColor: '#edd8c7' }}>Update Client</Button>
        </Form>
      </div>
    </div>
  );
};

export default UpdateClient;
