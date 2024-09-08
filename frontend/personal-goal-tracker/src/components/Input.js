import React from 'react';
import '../styles/Input.css';

function Input({ value, onChange, type = 'text', placeholder = '' }) {
  return (
    <input
      className="input"
      type={type}
      value={value}
      onChange={onChange}
      placeholder={placeholder}
    />
  );
}

export default Input;
