declare module '@apiverve/colorpalette' {
  export interface colorpaletteOptions {
    api_key: string;
    secure?: boolean;
  }

  export interface colorpaletteResponse {
    status: string;
    error: string | null;
    data: any;
    code?: number;
  }

  export default class colorpaletteWrapper {
    constructor(options: colorpaletteOptions);

    execute(callback: (error: any, data: colorpaletteResponse | null) => void): Promise<colorpaletteResponse>;
    execute(query: Record<string, any>, callback: (error: any, data: colorpaletteResponse | null) => void): Promise<colorpaletteResponse>;
    execute(query?: Record<string, any>): Promise<colorpaletteResponse>;
  }
}
