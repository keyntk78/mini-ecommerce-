import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'MiniEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44358/',
    redirectUri: baseUrl,
    clientId: 'MiniEcommerce_App',
    responseType: 'code',
    scope: 'offline_access MiniEcommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44366',
      rootNamespace: 'MiniEcommerce',
    },
  },
} as Environment;
